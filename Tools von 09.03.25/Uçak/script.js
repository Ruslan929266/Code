document.addEventListener('DOMContentLoaded', function() {
    const switchContainer = document.querySelector('.switch');
    const airplanes = document.querySelectorAll('.airplane');
    const switchButton = document.querySelector('.switch__button');
    const cloudLine = document.querySelector('.cloud-line');
    const sky = document.querySelector('.sky');
    const airport = document.querySelector('.airport');

    const getStyleVariable = (property, element = document.documentElement) => {
        return getComputedStyle(element).getPropertyValue(`--${property}`).trim();
    };

    // Cloud animation
    const animateClouds = (() => {
        const cloudFinalX = -cloudLine.children[0].clientWidth;
        const cloudTimeline = gsap.timeline({ repeat: -1 });
        cloudTimeline.to(cloudLine, { x: cloudFinalX, duration: 20, ease: 'none' });
    })();

    let isAnimating = false;
    const switchButtonFinalX = switchContainer.clientWidth - switchButton.clientWidth;
    const airplanesFinalX = airplanes[0].clientWidth + switchButton.clientWidth / 2 - airplanes[0].clientWidth / 2;
    const airplanesInitialX = -1 * (switchButton.clientWidth / 2 - airplanes[0].clientWidth / 2);

    const toggleAnimation = (isOn) => {
        const ease = 'power2.inOut';
        const duration = 0.5;
        const nextState = isOn ? 'off' : 'on';
        const background = getStyleVariable(`color-background-${nextState}`);
        const boxShadow = getStyleVariable(`shadow-${nextState}`);
        const switchButtonX = isOn ? 0 : switchButtonFinalX;
        const airplanesX = isOn ? airplanesInitialX : airplanesFinalX;
        const airportX = isOn ? -110 : -20;
        const opacity = isOn ? 0 : 1;

        gsap.to(document.body, { 
            backgroundColor: background, 
            duration, 
            ease 
        });

        gsap.to(switchContainer, { 
            boxShadow, 
            duration, 
            ease 
        });

        gsap.to(switchButton, { 
            x: switchButtonX, 
            duration, 
            ease 
        });

        gsap.to(airplanes, { 
            x: airplanesX, 
            duration, 
            ease 
        });

        gsap.to(airport, { 
            x: airportX, 
            duration, 
            ease 
        });

        gsap.to(sky, { 
            opacity, 
            duration, 
            ease, 
            onComplete() {
                isAnimating = false;
            }
        });
    };

    const toggleSwitch = () => {
        if (isAnimating) return;
        isAnimating = true;
        const isCurrentlyOn = switchContainer.classList.contains('-on');
        switchContainer.classList.toggle('-on');
        toggleAnimation(isCurrentlyOn);
    };

    switchContainer.addEventListener('click', toggleSwitch);
});